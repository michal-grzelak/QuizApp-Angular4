﻿using System;
using System.Collections.Generic;
using QuizAppApi.Models;

namespace QuizAppApi.Services
{
    public interface IAnswerService
    {
        void AddCorrectAnswer(CorrectAnswer correctAnswer);
        void AddToSeed(Answer answer);
        bool CheckAnswer(Answer answer);
        bool CheckAnswer(Guid questionId, Guid answerId);
        List<CorrectAnswer> GetCorrectAnswersList();
        Answer GetCorrectByQuestionId(Guid questionId);
        List<Answer> GetList();
        List<Answer> GetListByQuestionId(Guid questionId);
        bool Validate(Answer answer);
    }
}