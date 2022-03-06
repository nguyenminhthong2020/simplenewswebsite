ClassicEditor
    .create(document.querySelector('#content'), {
        licenseKey: '',
    })
    .then(editor => {
        window.editor = editor;
    })
    .catch(error => {
        console.error('Oops, something went wrong!');
        console.error('Please, report the following error on https://github.com/ckeditor/ckeditor5/issues with the build id and the error stack trace:');
        console.warn('Build id: mxefwd8uabpg-nvqywtx4rvf5');
        console.error(error);
    });

