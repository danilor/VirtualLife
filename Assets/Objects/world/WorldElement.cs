using System.Collections;
using System.Collections.Generic;


public class WorldElement {


    // Name of the World Element
    public string name { get; set; }

    // The posible porcent of this element in a map
    public int porcent { get; set; }
    // The location on height on the map
    public int location_h { get; set; }
    // The location on width on the map
    public int location_w { get; set; }
    // The location on deep on the map
    public int location_d { get; set; }
    // This will represent the color string on css style
    public string colorString { get; set; }

    // This should contain the adyacent WordElements to this one
    public WorldElement top, left, right, bottom;


    public WorldElement() {
            // Constructor
    }

    /**
     * STATIC METHODS
     */

    //  It will return the list of posible Word Elements
    // All porcents should add -100- at the end.
    public static WorldElement[] BasicWorldElements() {
        List<WorldElement> AvailableWorldElements = new List<WorldElement>();
        WorldElement aux = null;

        // Sabana
        aux = new WorldElement();
        aux.name = "Sabana";
        aux.porcent = 30; // %
        aux.colorString = "green";
        AvailableWorldElements.Add( aux );

        // Water
        aux = new WorldElement();
        aux.name = "Water";
        aux.porcent = 50; // %
        aux.colorString = "lightblue";
        AvailableWorldElements.Add( aux );

        // Forest
        aux = new WorldElement();
        aux.name = "Forest";
        aux.porcent = 20; // %
        aux.colorString = "darkgreen";
        AvailableWorldElements.Add( aux );

        // Now we return the list as an array
        return AvailableWorldElements.ToArray();
    }

}
