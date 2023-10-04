// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SL_PACKAGE_LOCATION.cs" company="SANRAL">
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
    /// The SL_PACKAGE_LOCATION Application Service.
    /// </summary>
    public  partial class SL_PACKAGE_LOCATIONApplicationService : ISL_PACKAGE_LOCATIONApplicationService
    {
    	public Guid ReturnSL_PACKAGE_LOCATIONNextValue() 
    	{ 
    		return repository.ReturnSL_PACKAGE_LOCATIONNextValue();
    	}
                 
    }
    
}
