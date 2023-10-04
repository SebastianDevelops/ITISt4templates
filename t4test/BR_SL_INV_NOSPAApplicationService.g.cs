// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BR_SL_INV_NOSPA.cs" company="SANRAL">
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
    /// The BR_SL_INV_NOSPA Application Service.
    /// </summary>
    public  partial class BR_SL_INV_NOSPAApplicationService : IBR_SL_INV_NOSPAApplicationService
    {
    	public Guid ReturnBR_SL_INV_NOSPANextValue() 
    	{ 
    		return repository.ReturnBR_SL_INV_NOSPANextValue();
    	}
                 
    }
    
}
