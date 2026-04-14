var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configurar el pipeline HTTP
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

// Mapear los controladores (MUY IMPORTANTE)
app.MapControllers();

app.Run();