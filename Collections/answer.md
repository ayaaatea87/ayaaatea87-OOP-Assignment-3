## Answer
S1 Find a student by national ID — thousands of times a day.
A1/ Dictionary

S2 Keep the tags of a course. The same tag must never be stored twice.
A2/ hash set

S3 Keep a student's grades in the order they were entered. The same grade can appear more than once.
A3/ list

S4 A public method returns the course price list. Callers can read prices but must not add or change any.
A4/IReadOnlyDictonary

S5 A timetable keyed by session start time. Sessions are added at any moment, and it must always print in
time order.
A5/ SortedDictionary

S6 A method returns results that the caller only loops over once — and may stop early.
A6/IEnumerable.



## IReadOnlyDictionary                    SortedDictionary

no instance direct                        create objrct with new
interface                                 class
read only (no add or remove )             mutable(accepted add , remove)
not sorted based on dictionary            sorted based on key
used when callers only need to read data  Used when data must always be ordered by key
                                       
