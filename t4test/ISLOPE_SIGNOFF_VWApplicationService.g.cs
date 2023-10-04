// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SLOPE_SIGNOFF_VW.cs" company="SANRAL">
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
    /// The SLOPE_SIGNOFF_VW Application Service.
    /// </summary>
    public  partial class SLOPE_SIGNOFF_VWApplicationService : ISLOPE_SIGNOFF_VWApplicationService
    {
    	public Guid ReturnSLOPE_SIGNOFF_VWNextValue() 
    	{ 
    		return repository.ReturnSLOPE_SIGNOFF_VWNextValue();
    	}
                 
    }
    
}
