<!DOCTYPE html>
{% load static %}
<link rel="stylesheet" href="{% static 'css/estilos.css' %}">
<html lang="es">
<head>
    <button type="button" class="btn btn-primary"
        style="--bs-btn-padding-y: .25rem; --bs-btn-padding-x: .5rem; --bs-btn-font-size: .75rem;">
        <a href="/">Inicio</a>
<button type="button" class="btn btn-primary"
        style="--bs-btn-padding-y: .25rem; --bs-btn-padding-x: .5rem; --bs-btn-font-size: .75rem;">
        <a href="/acerca/">Acerca</a>
        <button type="button" class="btn btn-primary"
        style="--bs-btn-padding-y: .25rem; --bs-btn-padding-x: .5rem; --bs-btn-font-size: .75rem;">
        <a href="/contacto/">Contacto</a>
</button>
</button>
</button>
    <meta charset="UTF-8">
    <title>Mi Sitio</title>
    <link rel="stylesheet" href="{% static 'css/styles.css' %}" />
    <link href="https://fonts.googleapis.com/css2?family=Roboto&display=swap" rel="stylesheet">
</head>
<body>
    <header>
        <nav>
        </nav>
    </header>

    <main>
        {% block contenido %}{% endblock %}
    </main>

    {% include 'paginas/footer.html' %}
</body>
</html>
