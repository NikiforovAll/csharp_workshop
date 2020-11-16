#load "records.csx"

var p0 = new Person0 () {
    FirstName = "First",
    LastName = "Person",
};

p0.LastName = "ModifiedPerson";

var p1 = new Person1 () {
    FirstName = "Second",
    LastName = "Person",
};

// p1.LastName = "ModifiedPerson"; //! ERROR

// ! ERROR; because it is not a record class, this might be changed in future
// var p11 = p1 with { LastName: "ModifiedPerson" }; 

var p2 = new Person2 () {
    FirstName = "Third",
    LastName = "Person",
};

var p3 = p2 with { LastName = "ModifiedPerson" };
var p4 = p2 with { LastName = "ModifiedPerson" };

WriteLine($"{p3}");
WriteLine($"{p4}");
WriteLine($"object.Equals: {Equals(p3, p4)}"); // Value-based equality
WriteLine($"object.ReferenceEquals: {ReferenceEquals(p3, p4)}");
