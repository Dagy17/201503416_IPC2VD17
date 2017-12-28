warlockdb_ipc2vd17
warlockdb_ipc2vd17
create table Usuario(
id_usuario serial primary key,
nickname varchar(25) not null,
nombre varchar(25) not null,
correo varchar(25) not null,
fecha_nacimiento date not null,
password varchar(25) not null
);

create table Publicacion(
id_publicacion serial primary key,
id_usuario bigint(20) unsigned not null,
tipo int(1) not null,
constraint fk_usuariopublica foreign key(id_usuario) references usuario(id_usuario)
);

create table Propuesta(
id_propuesta serial primary key,
id_usuario bigint(20) unsigned not null,
tipo int(1) not null,
Estado_propuesta int(1) not null,
id_publicacion bigint(20) unsigned null,
constraint fk_usuariopropuesta foreign key(id_usuario) references usuario(id_usuario),
constraint fk_propuestapubicada foreign key(id_publicacion) references publicacion(id_publicacion)
);

create table Proyecto(
id_proyecto serial primary key,
id_propuesta bigint(20) unsigned not null,
nombre varchar(25) not null,
presupuesto double not null,
Duracion int(2) not null,
integrantes int(2) not null,
constraint fk_proyectopropuesta foreign key(id_propuesta) references propuesta(id_propuesta)
);
alter table propuesta add column fecha_inicio date not null,

create table Tarea(
id_tarea serial primary key,
id_propuesta bigint(20) unsigned not null,
id_proyecto bigint(20) unsigned null,
nombre varchar(25) not null,
pago Decimal not null,
fecha_inicio date not null,
Duracion int(2) not null,
integrantes int(2) not null,
constraint fk_tareapropuesta foreign key(id_propuesta) references propuesta(id_propuesta),
constraint fk_tareaproyecto foreign key(id_proyecto) references proyecto(id_proyecto)
)

create table requisito(
id_tarea bigint(20) unsigned not null,
id_conocimiento bigint(20) unsigned not null,
constraint fk_requisitotarea foreign key(id_tarea) references tarea(id_tarea),
constraint fk_requisitoconoci foreign key(id_conocimiento) references conocimiento(id_conocimiento)
)

create table conoci_habili(
id_habilidad bigint(20) unsigned not null,
id_conocimiento bigint(20) unsigned not null,
constraint fk_conoci_habilihabilidad foreign key(id_habilidad) references habilidad(id_habilidad),
constraint fk_conoci_habiliconocimiento foreign key(id_conocimiento) references conocimiento(id_conocimiento)
)

create table habilidad(
id_habilidad serial primary key,
nombre_habilidad varchar(25) not null,
detalle_habiliad Text null
)

create table conocimiento(
id_conocimiento serial primary key,
nombre_conocimiento varchar(25) not null,
detalle_conocimiento text null
)

create table conoci_usuario(
id_usuario bigint(20) unsigned not null,
id_conocimiento bigint(20) unsigned not null,
puntaje int(2) not null,
constraint fk_conoci_usuariousuario foreign key(id_usuario) references usuario(id_usuario),
constraint fk_conoci_usuarioconocimiento foreign key(id_conocimiento) references conocimiento(id_conocimiento)
)
create table estado(
id_estado serial primary key,
id_publicacion bigint(20) unsigned not null,
texto_estado text not null,
constraint fk_estadopublicacion foreign key(id_publicacion) references publicacion(id_publicacion)
)

create table comentario(
id_comentario serial primary key,
id_estado bigint(20) unsigned not null,
id_usuario bigint(20) unsigned not null,
texto_comentario text not null,
constraint fk_comentarioestado foreign key(id_estado) references estado(id_estado),
constraint fk_comentariousuario foreign key(id_usuario) references usuario(id_usuario)
)
create table lista_contacto(
id_usuario bigint(20) unsigned not null,
id_contacto bigint(20) unsigned not null,
constraint fk_lista_contactousuario foreign key(id_usuario) references usuario(id_usuario),
constraint fk_lista_contactocontacto foreign key(id_contacto) references usuario(id_usuario)
)
create table asociacion(
id_asociacion serial primary key,
id_usuario bigint(20) unsigned not null,
nombre_asociacion varchar(25) not null,
detalle_asociacion text null,
constraint fk_asociacionusuario foreign key (id_usuario) references usuario(id_usuario)
)
drop table mensaje
create table mensaje(
id_mensaje serial primary key,
id_remitente bigint(20) unsigned not null,
id_destinatario bigint(20) unsigned not null,
texto_mensaje text not null,
id_proyecto bigint(20) unsigned null,
id_tarea bigint(20) unsigned null,
id_Asociacion bigint(20) unsigned null,
solicitud int(1) not null,
constraint fk_mensajeremitente foreign key(id_remitente) references usuario(id_usuario),
constraint fk_mensajedestinatario foreign key(id_destinatario) references usuario(id_usuario),
constraint fk_mensajeeproyecto foreign key(id_proyecto) references proyecto(id_proyecto),
constraint fk_mensajetarea foreign key(id_tarea) references tarea(id_tarea),
constraint fk_mensajeAsociacion foreign key(id_asociacion) references asociacion(id_asociacion)
)


create table participante(
id_participante serial primary key,
id_usuario bigint(20) unsigned not null,
id_proyecto bigint(20) unsigned null,
id_tarea bigint(20) unsigned null,
id_Asociacion bigint(20) unsigned null,
puesto varchar(25) null,
constraint fk_participanteusuario foreign key(id_usuario) references usuario(id_usuario),
constraint fk_participanteproyecto foreign key(id_proyecto) references proyecto(id_proyecto),
constraint fk_participantetarea foreign key(id_tarea) references tarea(id_tarea),
constraint fk_participanteAsociacion foreign key(id_asociacion) references asociacion(id_asociacion)
)

create table denuncia(
id_denuncia serial primary key,
id_denunciante bigint(20) unsigned not null,
id_proyecto bigint(20) unsigned null,
id_mensaje bigint(20) unsigned null,
id_comentario bigint(20) unsigned null,
id_tarea bigint(20) unsigned null,
id_estado bigint(20) unsigned null,
constraint fk_denunciqusuario foreign key(id_denunciante) references usuario(id_usuario),
constraint fk_denunciaproyecto foreign key(id_proyecto) references proyecto(id_proyecto),
constraint fk_denunciatarea foreign key(id_tarea) references tarea(id_tarea),
constraint fk_denunciamensaje foreign key(id_mensaje) references mensaje(id_mensaje),
constraint fk_denunciaestado foreign key(id_estado) references estado(id_estado),
constraint fk_denunciacomentario foreign key(id_comentario) references comentario(id_comentario)
)