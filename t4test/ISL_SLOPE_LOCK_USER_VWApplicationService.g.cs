// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SL_SLOPE_LOCK_USER_VW.cs" company="SANRAL">
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
    /// The SL_SLOPE_LOCK_USER_VW Application Service.
    /// </summary>
    public  partial class SL_SLOPE_LOCK_USER_VWApplicationService : ISL_SLOPE_LOCK_USER_VWApplicationService
    {
    	public Guid ReturnSL_SLOPE_LOCK_USER_VWNextValue() 
    	{ 
    		return repository.ReturnSL_SLOPE_LOCK_USER_VWNextValue();
    	}
                 
    }
    
}
