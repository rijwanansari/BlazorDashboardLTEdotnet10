window.dashboardTheme = {
    toggleSidebar: function () {
        const shell = document.getElementById("appShell");
        if (!shell) {
            return;
        }

        shell.classList.toggle("sidebar-open");
    }
};
