namespace Engine.Core {

/*------------------------------------------------
 * USINGS
 *----------------------------------------------*/

using System;
using System.Collections.Generic;

/*------------------------------------------------
 * CLASSES
 *----------------------------------------------*/

// Base component class for all game components.
public abstract class Base_Component {}

// Base entity class for all game entities.
public class Base_Entity {
    // Components attached to this entity.
     readonly Dictionary<Type, Base_Component> components = new Dictionary<Type, Base_Component>();

    // Unique entity id, set by the game engine.
    public Int64 id;

    private static Int64 s_id = 1;

    public Base_Entity() {
        id = s_id++;
    }

    // Adds the specified components to the entity.
    public void add_components(params Base_Component[] components) {
        int n = components.Length;
        for (int i = 0; i < n; i++) {
            var component = components[i];
            this.components.Add(component.GetType(), component);
        }
    }

    // Retrieves the component of the specified type, attached to the entity.
    // Returns null if no such component exists.
    public T get_component<T>() where T : Base_Component  {
        Base_Component component;
        components.TryGetValue(typeof (T), out component);
        return ((T)component);
    }
}

// Base subsystem class for all game subsystems.
public abstract class Base_Subsystem {
    // Override this to perform draw operations (normally 60 calls per sec?)
    public virtual void draw(float dt) {}

    // Override to perform update logic (unlimited calls per sec?)
    public virtual void update(float dt) {}
}

public abstract class Game_Impl {
    public virtual void init() {}

    public virtual void cleanup() {}

    public virtual void update(float t, float dt) {}

    public virtual void draw(float t, float dt) {
    }
}

}