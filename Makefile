app/run:
	dotnet run --project DosSancto.Web

app/watch:
	dotnet watch run --project DosSancto.Web

css/watch:
	cd DosSancto.Web; npx tailwindcss -i wwwroot/lib/tailwind/app.css -o wwwroot/lib/tailwind/app.min.css --watch
