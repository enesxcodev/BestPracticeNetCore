namespace BestPractice.ResultPattern
{
    public class ResultUsage
    {
        public void Usage()
        {
            //Result<QuestionDto>.Success(questionDto);
            //return Result<Guid>.Created(question.Id);
            //return Result<QuestionDto>.NotFound("Soru bulunamadı.");
            //return Result.Validation("Başlık zorunludur.","Sınıf seçilmelidir.");
            //return Result.Conflict("Bu soru zaten mevcut.");
        }
    }
}
