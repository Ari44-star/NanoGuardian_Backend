var builder = WebApplication.CreateBuilder(args);

// 1. Agrega los servicios para los Controladores
builder.Services.AddControllers();

// 2. Agrega el generador de Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 3. Activa Swagger siempre (para que no te falle por el modo Development)
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

// 4. Mapea los controladores
app.MapControllers();

app.Run();