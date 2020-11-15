#load "records.csx"

var p0 = new Person0 {
    FirstName = "First",
    LastName = "Person",
};

p0.LastName = "ModifiedPerson";

var p1 = new Person1 {
    FirstName = "Second",
    LastName = "Person",
};

// p1.LastName = "ModifiedPerson"; //! ERROR


// var p2 = p1 with { LastName: "ModifiedPerson" }; // ! ERROR

var p2 = new Person2 {
    FirstName = "Third",
    LastName = "Person",
};

var p3 = p2 with { LastName = "ModifiedPerson" };
var p4 = p2 with { LastName = "ModifiedPerson" };

WriteLine($"{p3}");
WriteLine($"{p4}");
WriteLine($"object.Equals: {Equals(p3, p4)}"); // Value-based equality
WriteLine($"object.ReferenceEquals: {ReferenceEquals(p3, p4)}");
