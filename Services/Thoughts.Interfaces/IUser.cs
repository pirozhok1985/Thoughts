﻿using System.ComponentModel.DataAnnotations;

using Thoughts.Interfaces.Base.Entities;

namespace Thoughts.Interfaces;

/// <summary>
/// Пользователь
/// </summary>
public interface IUser : IEntity<string>
{
    /// <summary>Статус пользователя</summary>
    [Required]
    public IStatus Status { get; set; }

    [Required, MinLength(2)]
    public string LastName { get; set; }

    /// <summary>Имя</summary>
    [Required, MinLength(2)]
    public string FirstName { get; set; }

    /// <summary>Отчество</summary>
    public string? Patronymic { get; set; }

    /// <summary>Дата рождения</summary>
    public DateTime Birthday { get; set; }

    /// <summary>Псевдоним (отображаемое имя автора)</summary>
    [Required]
    public string NickName { get; set; }

    /// <summary>Роли пользователя</summary>
    public ICollection<IRole> Roles { get; set; }
}
