# JWT Authentication in ASP.NET Core

JWT (JSON Web Token) is a standard for securely transmitting information between a client and server as a JSON object. In ASP.NET Core, JWT is often used for stateless authentication in API applications, enabling secure communication without relying on server-side session data.

### Purpose of JWT in APIs

JWT allows an API to authenticate requests independently, making it ideal for distributed, stateless applications. With JWT, clients can include a token in each request, allowing the server to validate the client’s identity without needing to maintain session information. This approach is especially useful in microservices, mobile applications, and Single Page Applications (SPAs) where statelessness and efficiency are key.

### How JWT Works in ASP.NET Core

- **Authentication Token**: Upon successful login, the server generates a JWT and sends it to the client, who stores it securely (usually in local storage or a cookie).
- **Authorization Header**: For each subsequent request to a protected endpoint, the client includes the JWT in the `Authorization` header (`Authorization: Bearer <token>`).
- **Token Validation**: The server verifies the token's integrity and checks that it has not expired, ensuring the request’s authenticity.

### Security Advantages

1. **Stateless**: JWT does not require server-side sessions, allowing for more scalable and stateless systems.
2. **Tamper-Proof**: JWTs are digitally signed, making them secure and resistant to tampering.
3. **Efficient**: Tokens are compact and suitable for APIs where lightweight and fast communication is necessary.

Using JWT in ASP.NET Core APIs ensures secure, stateless communication, enhancing security and scalability for modern web applications.

### What is JSON?

**JSON** (JavaScript Object Notation) is a lightweight data-interchange format that is easy for both humans and machines to read and write. It represents data as key-value pairs, making it versatile for transmitting structured data across networked applications. JSON’s compact format and readability make it widely used for APIs, where it efficiently encodes data exchanged between a client and server.


### Why JSON? ###
JSON's simple structure (key-value pairs) is highly effective for transmitting data between a server and a client, particularly in RESTful APIs.

### Testing Your API with Postman ###
Postman is a popular tool for testing APIs, allowing you to easily send requests, view responses, and automate testing.

### Getting Started with Postman ###
1. Download and Install Postman Desktop: [Download here.](https://www.postman.com/)
2. Create a Collection: Collections help organize API requests. Create one for each project to keep things organized.
3. Add and Configure Requests:
Set the HTTP method (e.g., GET, POST).
Enter the endpoint URL (e.g., http://localhost:5000/api/products).

Add headers if required, such as Content-Type: application/json or Authorization: Bearer <token>.
Send and View Responses: Send requests to the API and view responses in the Postman interface. You can debug response data, status codes, and more.
