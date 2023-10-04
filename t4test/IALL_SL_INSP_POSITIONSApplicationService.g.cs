// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ALL_SL_INSP_POSITIONS.cs" company="SANRAL">
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
    /// The ALL_SL_INSP_POSITIONS Application Service.
    /// </summary>
    public  partial class ALL_SL_INSP_POSITIONSApplicationService : IALL_SL_INSP_POSITIONSApplicationService
    {
    	public Guid ReturnALL_SL_INSP_POSITIONSNextValue() 
    	{ 
    		return repository.ReturnALL_SL_INSP_POSITIONSNextValue();
    	}
                 
    }
    
}
