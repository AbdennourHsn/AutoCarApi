# AutoCarVR project's Api

**Note: To maintain the confidentiality of the project, I have made some modifications to the code, ensuring the protection of sensitive features.**


 ![logo1](https://github.com/AbdennourHsn/AutoCarApi/assets/119530347/3e631f9f-8593-4583-b3e5-e268fb68135c)<svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 159 25.2"><defs>

</defs><g id="Layer_2" data-name="Layer 2"><g id="Layer_1-2" data-name="Layer 1"><path class="cls-1" d="M46.7,17.1l-2.5,7.7H41L49.2.5H53l8.3,24.3H57.9l-2.6-7.7Zm8-2.4-2.4-7L51,3.3h0L49.7,7.7l-2.3,7Z"/><path class="cls-1" d="M78.9,20v4.8H76.2L76,21.9h0l-5.8,3.3-6-7.7V7.3h3.2V17l3.8,5.5,4.2-2.8.3-1.7V7.3h3.2Z"/><path class="cls-1" d="M87.9,2.3v5h4.6V9.8H87.9v9.4l2.4,3.3,1.9-.2v2.4l-2.8.4-3.4-1.3-1.3-4.5V9.8H82.1V7.3h2.7V3.2Z"/><path class="cls-1" d="M111.6,15.9l-8.7,9.3-8.3-9,8.6-9.3Zm-13.8.2,5.3,6.7,5.3-6.8-5.3-6.7Z"/><path class="cls-2" d="M124.5,24.8h-2.7l-.6-.5-4-8L114,9.1V.8l.4-.7H121l.4.4-.2,4.2L121,9.2l3.6,7.8,2.2-4.3,1.7-4.2V.3H135l.5.4V8.7l-3.5,8L128,24.3l-.3.4h-3.2Z"/><path class="cls-2" d="M159,24.6l-.3.2h-6.9l-.3-.4-.8-2-2.1-5.2-1.5-.8h-1.8l-.2.9.2,3.5.2,3.6-.2.4h-6.7l-.5-.6.2-5.8.2-5.9L138.1.9V.7l.6-.4L144,.1h5.2l6.5,1.8,2.9,5.9-.7,4.1-2.7,3-.5.5,2.2,4.4ZM151.7,8.8l-1.5-2.9-3.4-.7-1.7.5v5.8l.6.2,2.2.2Z"/><path class="cls-3" d="M4.4,18.1H1.7A1.2,1.2,0,0,1,.5,16.9V12a1.2,1.2,0,0,1,1.2-1.2H4.4Z"/><path class="cls-3" d="M4.9,18.6H1.7A1.8,1.8,0,0,1,0,16.9V12a1.7,1.7,0,0,1,1.7-1.7H4.9ZM1.7,11.2a.9.9,0,0,0-.8.8v4.9a.9.9,0,0,0,.8.8H3.9V11.2Z"/><path class="cls-3" d="M40.2,18.1H37.5V10.8h2.7A1.2,1.2,0,0,1,41.5,12v4.9A1.2,1.2,0,0,1,40.2,18.1Z"/><path class="cls-3" d="M40.2,18.6H37.1V10.3h3.1A1.6,1.6,0,0,1,41.9,12v4.9A1.7,1.7,0,0,1,40.2,18.6ZM38,17.7h2.2a.8.8,0,0,0,.8-.8V12a.8.8,0,0,0-.8-.8H38Z"/><path class="cls-3" d="M23.7,5.5H18.2V2.4a1.2,1.2,0,0,1,1.3-1.2h2.9a1.2,1.2,0,0,1,1.3,1.2V5.5Z"/><path class="cls-3" d="M24.2,5.9H17.7V2.4A1.8,1.8,0,0,1,19.5.7h2.9a1.8,1.8,0,0,1,1.8,1.7ZM18.7,5h4.6V2.4a.9.9,0,0,0-.9-.8H19.5a.8.8,0,0,0-.8.8Z"/><path class="cls-2" d="M33.8,5.5H8.1A3.6,3.6,0,0,0,4.4,9.2V19.7a3.7,3.7,0,0,0,3.7,3.7h6.7a4.8,4.8,0,0,0,3.5-1.6A3.6,3.6,0,0,1,21,20.6a4,4,0,0,1,2.7,1.2,4.4,4.4,0,0,0,3.4,1.6h6.7a3.7,3.7,0,0,0,3.7-3.7V9.2A3.6,3.6,0,0,0,33.8,5.5Z"/><path class="cls-1" d="M33.8,23.9H27.1a5.3,5.3,0,0,1-3.8-1.8A3,3,0,0,0,21,21a3.2,3.2,0,0,0-2.4,1.1,5.3,5.3,0,0,1-3.8,1.8H8.1a4.2,4.2,0,0,1-4.2-4.2V9.2A4.2,4.2,0,0,1,8.1,5H33.8A4.2,4.2,0,0,1,38,9.2V19.7A4.2,4.2,0,0,1,33.8,23.9ZM21,20.1a4.1,4.1,0,0,1,3,1.4,4.1,4.1,0,0,0,3.1,1.4h6.7a3.2,3.2,0,0,0,3.3-3.2V9.2a3.3,3.3,0,0,0-3.3-3.3H8.1A3.2,3.2,0,0,0,4.9,9.2V19.7a3.2,3.2,0,0,0,3.2,3.2h6.7a4.1,4.1,0,0,0,3.1-1.4A4.1,4.1,0,0,1,21,20.1Z"/><path class="cls-4" d="M7.8,12.4H7.5a.5.5,0,0,1,0-.7L11.1,8h.7a.9.9,0,0,1,0,.7L8.2,12.3Z"/><path class="cls-4" d="M13.6,10.6h-.3a.5.5,0,0,1,0-.7L15,8.1h.7a.9.9,0,0,1,0,.7L14,10.5Z"/><path class="cls-4" d="M7.9,16.3H7.6a.5.5,0,0,1,0-.7l4.1-4.1a.5.5,0,1,1,.7.7L8.3,16.2Z"/></g></g></svg>
<hr>

<br>
<div align="center" style="margin:20px;">
  <img src="https://github.com/AbdennourHsn/AutoCarApi/assets/119530347/58f5ae3d-e93e-4017-a5bf-973c3f49f52e" alt="rest-api-icon" width="100">
  <img src="https://github.com/AbdennourHsn/AutoCarApi/assets/119530347/c9e65971-5547-49d4-90a2-107169098b11" alt="Microsoft .NET logo" width="100">
</div>

<br>


In order to ensure the stability, security, and performance of our VR application, as well as to facilitate the integration and communication of different phases of our application with the database, using .NET Web API, we can establish a secure and reliable communication between the frontend of our VR application and the web interface with the backend. This allows us to manage various functionalities, such as user authentication, showroom management, and data storage, in an effective and structured manner.
<div align="center">
<img width="654" alt="Screenshot 2024-01-22 at 13 32 19" src="https://github.com/AbdennourHsn/AutoCarApi/assets/119530347/52d39e59-20d1-4a38-92f2-3df853c09b79">
</div>

## Structure of the .NET Web API
The structuring of a project is essential for organizing files in a logical, clear, and consistent manner. This approach allows the application to evolve smoothly, even with the gradual addition of numerous files, thus avoiding disorder and the ordeal of finding a specific piece of code.
The structure of the web API is as follows:

- **Assets:** This folder contains various types of resources, such as images and files.

- **Controllers:** This folder contains controller classes that handle HTTP requests and associated actions.

- **DTOs (Data Transfer Objects):** Used to store classes that serve to transfer data between different layers of your application.

- **Entities:** This folder contains classes representing the main entities of the application.

- **Interfaces:** This folder contains interfaces describing the contracts of application classes.

- **Services:** This folder contains classes that implement the business logic of the application.

## Entities Diagram
<img width="933" alt="Screenshot 2024-01-22 at 13 46 27" src="https://github.com/AbdennourHsn/AutoCarApi/assets/119530347/96e1af54-1931-4e6a-931c-ff21cb47a2d3">

## Controllers



      │   │   ├── BaseApiController.cs
      
      │   │   ├── AccountController.cs // Manages user accounts and authentication-related operations, such as user registration, login
      
      │   │   ├── CarsController.cs // Handles operations related to cars,list of cars, adding new cars, updating car information
      
      │   │   ├── ColorsController.cs
      
      │   │   ├── ShowroomsController.cs  //Deals with showroom-related functionalities,displaying information about showrooms, adding new showrooms...
      
      │   │   ├── UsersController.cs //Handles user-related operations that are not directly tied to account management, such as retrieving user profiles, updating user information
      
      │   │   ├── EnvironementController.cs
      

## Some API Endpoints
<img width="816" alt="Screenshot 2024-01-22 at 13 48 25" src="https://github.com/AbdennourHsn/AutoCarApi/assets/119530347/f95a78c3-c196-4adb-b49c-17e9f06e2bca">
<img width="816" alt="Screenshot 2024-01-22 at 13 50 28" src="https://github.com/AbdennourHsn/AutoCarApi/assets/119530347/136bb31d-0fa3-491d-9088-57dd34234fe0">

## Challenges

- **Recieve and Upload files of 3D Models from diffrents format (gltf , Fbx , glb , Obj ...) :**

  

**Recieve Car Model file :**

        [HttpPost("add")]
        [RequestSizeLimit(100_000_000)]
        public async Task<IActionResult> UploadModel([FromForm] CarDto dto, IFormFile file)
  
        {
            string filePath;

            try{filePath = await SaveUploadedFile(file);}
            catch (ArgumentException ex){return BadRequest(ex.Message);}
  
            User owner = await _context.Users.FindAsync(dto.OwnerId);
  
            ICollection<Color> colors=JsonToColors(dto.Colors);
            Car car= new Car{
                 ModelName=dto.ModelName,
                 FilePath=filePath,
                 Descriptiom=dto.Descriptiom,
                 Price= dto.Price,
                 MaxSpeed=dto.MaxSpeed,
                 Categorie=dto.Categorie,
                 Colors=colors,
                 Owner=owner,
             };
             _context.Cars.Add(car);
             await _context.SaveChangesAsync();
            return Ok("Upload successful!");
        }

       private async  Task<string> SaveUploadedFile(IFormFile file){
            if (file == null || file.Length == 0)
            {
                 throw new ArgumentException("No file uploaded");
            }

            // Save the uploaded file
            var filePath = "assets/cars/"+file.FileName;
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return filePath;
        } 

**Send Car Model file :**

        [HttpGet("file/{name}")]
        public IActionResult GetCarFile(string name)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "assets", "cars" , name);
            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);

            var contentType = "application/octet-stream";

            return new FileStreamResult(fileStream, contentType);
        }


