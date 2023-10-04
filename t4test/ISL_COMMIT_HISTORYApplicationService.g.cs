// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SL_COMMIT_HISTORY.cs" company="SANRAL">
//   Copyright (c) 2014 All Rights Reserved
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace ITIS.Web.DataAccess.Models.ApplicationService.SlopeModel
{
    #region Using
	using System;
    using ITIS.Web.DataAccess.Models.IApplicationService.SlopeModel;
    using ITIS.Web.DataAccess.Models.IRepository.SlopeModel;
    #endregion

    /// <summary>
    /// The SL_COMMIT_HISTORY Application Service.
    /// </summary>
    public  partial class SL_COMMIT_HISTORYApplicationService : ISL_COMMIT_HISTORYApplicationService
    {
    	public Guid ReturnSL_COMMIT_HISTORYNextValue() 
    	{ 
    		return repository.ReturnSL_COMMIT_HISTORYNextValue();
    	}
                 
    }
    
}
