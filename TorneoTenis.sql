----CREACION DE TABLAS----

CREATE TABLE tblTorneo(
    torCod number(10) not null,
    torNombre varchar(20) not null,
    CONSTRAINT Pk_tblTorneo PRIMARY KEY(torCod)
);

create table tblTenista(
    tenCod number(10) not null,
    tenNombre varchar(20) not null,
    tenApellido varchar(20) not null,
    tenCategoria varchar(20) not null,
    CONSTRAINT ckc_tenCat check (tenCategoria in('NOVATO','JUNIOR','SENIOR')),
    CONSTRAINT Pk_tblTenista PRIMARY key(tenCod)
);
create table tblRegistro(
    regCodTenista number(10) not null,
    regCodTorneo number(10) not null,
    regFecha date not null,
    regHora VARCHAR(10) not null,
    CONSTRAINT Pk_tblRegistro PRIMARY KEY(regCodTenista,regCodTorneo,regFecha,regHora),
    CONSTRAINT Fk_regTenista FOREIGN KEY(regCodTenista) REFERENCES tblTenista(tenCod) ,
    CONSTRAINT Fk_regTorneo FOREIGN KEY(regCodTorneo) REFERENCES tblTorneo(torCod)
);

----INSERTS DE LAS TABLAS----

insert into tblTenista(tenCod,tenNombre,tenApellido,tenCategoria) values(1,'Sebastian','Rosero','SENIOR');
insert into tblTenista(tenCod,tenNombre,tenApellido,tenCategoria) values(2,'Kevin','Eraso','NOVATO');
insert into tblTenista(tenCod,tenNombre,tenApellido,tenCategoria) values(3,'Javi','Casamachin','JUNIOR');
insert into tblTenista(tenCod,tenNombre,tenApellido,tenCategoria) values(4,'Brayan','Herrera','JUNIOR');
insert into tblTenista(tenCod,tenNombre,tenApellido,tenCategoria) values(5,'Jose','Chilito','NOVATO');
insert into tblTenista(tenCod,tenNombre,tenApellido,tenCategoria) values(6,'Maluma','Yepes','JUNIOR');
insert into tblTenista(tenCod,tenNombre,tenApellido,tenCategoria) values(7,'Harold','Qilindo','JUNIOR');
insert into tblTenista(tenCod,tenNombre,tenApellido,tenCategoria) values(8,'Camilo','Rodallega','NOVATO');
insert into tblTenista(tenCod,tenNombre,tenApellido,tenCategoria) values(9,'Carlos','Hernandez','JUNIOR');
insert into tblTenista(tenCod,tenNombre,tenApellido,tenCategoria) values(10,'Juanes','Manrique','SENIOR');

insert into tblTorneo(torCod,torNombre) values(001,'ATP de Australia');
insert into tblTorneo(torCod,torNombre) values(002,'Wimbledon');

----CONSULTAS REALIZADAS----

select count(tenCod) cuenta from tblTenista where tencategoria = 'SENIOR';

select tbltorneo.tornombre,tbltenista.tencod,tbltenista.tennombre,tbltenista.tenApellido, tblRegistro.regHora from tblRegistro 
INNER JOIN tbltorneo on tbltorneo.torcod=tblRegistro.regCodTorneo INNER JOIN tbltenista on tblregistro.regcodtenista=tbltenista.tenCod 
where tbltorneo.torcod=1 and (tblRegistro.regfecha='01/02/2023') 