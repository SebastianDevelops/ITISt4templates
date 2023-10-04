// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SL_ALLOCATION.cs" company="SANRAL">
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
    /// The SL_ALLOCATION Application Service.
    /// </summary>
    public  partial class SL_ALLOCATIONApplicationService : ISL_ALLOCATIONApplicationService
    {
    	public Guid ReturnSL_ALLOCATIONNextValue() 
    	{ 
    		return repository.ReturnSL_ALLOCATIONNextValue();
    	}
                 
    }
    
}
