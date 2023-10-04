// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BR_SL_INV_DIMENSIONS.cs" company="SANRAL">
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
    /// The BR_SL_INV_DIMENSIONS Application Service.
    /// </summary>
    public  partial class BR_SL_INV_DIMENSIONSApplicationService : IBR_SL_INV_DIMENSIONSApplicationService
    {
    	public Guid ReturnBR_SL_INV_DIMENSIONSNextValue() 
    	{ 
    		return repository.ReturnBR_SL_INV_DIMENSIONSNextValue();
    	}
                 
    }
    
}
