﻿using MediatR;
using Notes.Application.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Notes.Application.Common.Exception;
using Notes.Domain;
using Notes.Application.Common.Mappings;

namespace Notes.Application.Notes.Queries.GetNoteList
{
    public class NoteLookupDto : IMapWith<Note>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Note, NoteLookupDto>()
                .ForMember(noteDto => noteDto.Id,
                    opt => opt.MapFrom(noteDto => noteDto.Id))
                .ForMember(noteDto => noteDto.Title,
                    opt => opt.MapFrom(noteDto => noteDto.Title));
        }

    }
}
