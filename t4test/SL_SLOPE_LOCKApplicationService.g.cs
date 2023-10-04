// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SL_SLOPE_LOCK.cs" company="SANRAL">
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
    /// The SL_SLOPE_LOCK Application Service.
    /// </summary>
    public  partial class SL_SLOPE_LOCKApplicationService : ISL_SLOPE_LOCKApplicationService
    {
    	public Guid ReturnSL_SLOPE_LOCKNextValue() 
    	{ 
    		return repository.ReturnSL_SLOPE_LOCKNextValue();
    	}
                 
    }
    
}
