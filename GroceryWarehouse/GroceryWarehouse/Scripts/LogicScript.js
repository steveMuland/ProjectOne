
function IdTypeChange() {
    var Zim = document.getElementById('ZimId');
    var Foreign = document.getElementById('ForeignId');
    var Option = document.getElementById('Identity').value;

    if(Option=="Zim")
    {
        Zim.className = 'form-group';
        Foreign.className = 'form-group hidden';        
    }
    if(Option=="Foreign Id") {
        Zim.className = 'form-group hidden';
        Foreign.className = 'form-group';
    }
}