// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CU_SL_INV_DIMENSIONS.cs" company="SANRAL">
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
    /// The CU_SL_INV_DIMENSIONS Application Service.
    /// </summary>
    public  partial class CU_SL_INV_DIMENSIONSApplicationService : ICU_SL_INV_DIMENSIONSApplicationService
    {
    	public Guid ReturnCU_SL_INV_DIMENSIONSNextValue() 
    	{ 
    		return repository.ReturnCU_SL_INV_DIMENSIONSNextValue();
    	}
                 
    }
    
}
