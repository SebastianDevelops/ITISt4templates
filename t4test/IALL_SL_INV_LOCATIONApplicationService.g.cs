// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ALL_SL_INV_LOCATION.cs" company="SANRAL">
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
    /// The ALL_SL_INV_LOCATION Application Service.
    /// </summary>
    public  partial class ALL_SL_INV_LOCATIONApplicationService : IALL_SL_INV_LOCATIONApplicationService
    {
    	public Guid ReturnALL_SL_INV_LOCATIONNextValue() 
    	{ 
    		return repository.ReturnALL_SL_INV_LOCATIONNextValue();
    	}
                 
    }
    
}
