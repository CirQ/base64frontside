# base64frontside
This windows form application calls the back side encode/decode algorithms to interact with user with base64 scheme.

The application accepts an arbitrary UTF8 character string as input and then output its Base64 form, vise versa. The main topic of this practice is to know the ways to call a C function in the C# program, the key point is concerning the variable types conversation.

Since the backside is written in C and only accepts valid encoded string, the validation of input should be carried out in the front side. The power of regular expression can be applied in our front side application.
