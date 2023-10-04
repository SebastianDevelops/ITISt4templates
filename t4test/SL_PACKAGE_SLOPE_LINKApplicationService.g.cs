// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SL_PACKAGE_SLOPE_LINK.cs" company="SANRAL">
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
    /// The SL_PACKAGE_SLOPE_LINK Application Service.
    /// </summary>
    public  partial class SL_PACKAGE_SLOPE_LINKApplicationService : ISL_PACKAGE_SLOPE_LINKApplicationService
    {
    	public Guid ReturnSL_PACKAGE_SLOPE_LINKNextValue() 
    	{ 
    		return repository.ReturnSL_PACKAGE_SLOPE_LINKNextValue();
    	}
                 
    }
    
}
