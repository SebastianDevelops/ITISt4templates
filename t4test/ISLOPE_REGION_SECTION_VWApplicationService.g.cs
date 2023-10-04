// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SLOPE_REGION_SECTION_VW.cs" company="SANRAL">
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
    /// The SLOPE_REGION_SECTION_VW Application Service.
    /// </summary>
    public  partial class SLOPE_REGION_SECTION_VWApplicationService : ISLOPE_REGION_SECTION_VWApplicationService
    {
    	public Guid ReturnSLOPE_REGION_SECTION_VWNextValue() 
    	{ 
    		return repository.ReturnSLOPE_REGION_SECTION_VWNextValue();
    	}
                 
    }
    
}
