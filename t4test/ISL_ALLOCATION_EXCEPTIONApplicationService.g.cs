// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SL_ALLOCATION_EXCEPTION.cs" company="SANRAL">
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
    /// The SL_ALLOCATION_EXCEPTION Application Service.
    /// </summary>
    public  partial class SL_ALLOCATION_EXCEPTIONApplicationService : ISL_ALLOCATION_EXCEPTIONApplicationService
    {
    	public Guid ReturnSL_ALLOCATION_EXCEPTIONNextValue() 
    	{ 
    		return repository.ReturnSL_ALLOCATION_EXCEPTIONNextValue();
    	}
                 
    }
    
}
