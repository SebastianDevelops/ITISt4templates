// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SL_PACKAGE_SLOPE_LINK_VW.cs" company="SANRAL">
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
    /// The SL_PACKAGE_SLOPE_LINK_VW Application Service.
    /// </summary>
    public  partial class SL_PACKAGE_SLOPE_LINK_VWApplicationService : ISL_PACKAGE_SLOPE_LINK_VWApplicationService
    {
    	public Guid ReturnSL_PACKAGE_SLOPE_LINK_VWNextValue() 
    	{ 
    		return repository.ReturnSL_PACKAGE_SLOPE_LINK_VWNextValue();
    	}
                 
    }
    
}
