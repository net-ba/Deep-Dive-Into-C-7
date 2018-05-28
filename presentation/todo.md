## Todo

* default w/ type inference
    * we no lonfer need write default(T) if it is obvious
    * example default parameter
* Better overload resolution in 7.3 
    * Task.Run example
* 7.2 name argument without naming all following arguments 
    * test if reverse first two but third stay
* generics
    * Remove delegate and Enum type constrains in generics 
    * unmanaged constrains in generics (unsafe code)
* Local functions
    * why
* Tuples
    * tuples equality (comparsion per element )
* ref parameter
    * now extension methods can take ref as this parameter
* in parameter 
    * readonly ref - efficiency without the risk
    * in keyword can be ommited
    * we can pass even value
* ref return
* ref readonly
    * reassigning (???)
* ref condiftional - weird stuff (???)
* Span<T> -
    * continuous chunk of memory 
    * pointing to someoneelse memory
    * thanks to ref return write to underlying memory (array)
    * we can stackalloc span (in safe code)
* ReadOnlySpan
     