// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ALL_SL_INV_ORIENTATION.cs" company="SANRAL">
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
    /// The ALL_SL_INV_ORIENTATION Application Service.
    /// </summary>
    public  partial class ALL_SL_INV_ORIENTATIONApplicationService : IALL_SL_INV_ORIENTATIONApplicationService
    {
    	public Guid ReturnALL_SL_INV_ORIENTATIONNextValue() 
    	{ 
    		return repository.ReturnALL_SL_INV_ORIENTATIONNextValue();
    	}
                 
    }
    
}
