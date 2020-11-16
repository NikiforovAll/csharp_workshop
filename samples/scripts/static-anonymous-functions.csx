string text = "{0} is a beautiful country !";
// const string text = "{0} is a beautiful country!";

static void PromoteCountry(Func<string, string> func)
{
    var countries = new List<string> {
        "Canada",
        "France",
        "Japan"
    };
    foreach (var country in countries)
        WriteLine(func(country));
}

// TODO: add static modifier
PromoteCountry(country => string.Format(text, country));

// “Anonymous methods are not cheap:”

// Overhead of a delegate invocation (very very small, but it does exist).
// 2 heap allocations if a lambda captures local variable or argument of enclosing method (one for closure instance and another one for a delegate itself).
// 1 heap allocation if a lambda captures an enclosing instance state (just a delegate allocation).
// 0 heap allocations only if a lambda does not capture anything or captures a static state.

