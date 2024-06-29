$(document).ready(function () {
    $('#mobile_btn').click(function () {
        $('#mobile_menu').toggleClass('active');
        $(this).find('i').toggleClass('fa-bars fa-x');
    });

    const sections = $('section');
    const navItms = $('.nav-item');

    $(window).on('scroll', function () {
        const header = $('header');
        const scrollPosition = $(window).scrollTop() - header.outerHeight();
    });

    const buttons = document.querySelectorAll('.card .btn-default');

    buttons.forEach((button, index) => {
        button.addEventListener('click', () => {
            document.body.style.overflow = 'hidden';  // Desabilita o scroll

            const modal = document.getElementById('modal');
            const bgDark = document.getElementById('bg-dark');

            bgDark.style.top = `${window.scrollY + window.innerHeight / 20000}px`;
            bgDark.style.visibility = 'visible';

            modal.style.top = `${window.scrollY + window.innerHeight / 5}px`;
            modal.style.visibility = 'visible';

            const img = document.querySelectorAll('.card .psycho-image')[index];
            const name = document.querySelectorAll('.card h3')[index];
            const description = document.querySelectorAll('.card .psycho-description')[index];
            const rate = document.querySelectorAll('.card .psycho-rate')[index];
            const price = document.querySelectorAll('.card .psycho-price h4')[index];

            modal.innerHTML = `
                <div class="psycho-brain">
                <i class="fa-solid fa-brain"></i>
                </div>
                <img src="${img.src}" class="psycho-image" alt="berg">
                <h3 class="psycho-title">${name.innerText}</h3>
                <span class="psycho-description">${description.innerHTML}</span>
                <div class="psycho-rate">${rate.innerHTML}</div>
                <div class="psycho-price">
                    <h4>${price.innerText}</h4>
                    <!-- Aqui está o botão "Chat" -->
                    <a href="http://127.0.0.1:5500/HTML/Chat/index.html" class="chat-btn">
                        <button class="btn-default">Chat</button>
                    </a>
                    <button class="btn-default" onclick="modalOut()">Cancelar</button>
                </div>
            `;
        });
    });
});

const modalOut = () => {
    const modal = document.getElementById('modal');
    const bgDark = document.getElementById('bg-dark');
    modal.style.visibility = 'hidden';
    bgDark.style.visibility = 'hidden';
    document.body.style.overflow = 'auto';
};

function toggleEspecialidades() {
    const elemento = document.getElementById('especialidades_list');
    elemento.classList.toggle('escondido');
}

function changeActive(clickedItem) {
    const navItems = document.querySelectorAll('.nav_item');
    navItems.forEach(item => {
        item.classList.remove('active');
    });
    clickedItem.classList.add('active');
}
