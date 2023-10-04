// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ALL_SLOPEIDS.cs" company="SANRAL">
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
    /// The ALL_SLOPEIDS Application Service.
    /// </summary>
    public  partial class ALL_SLOPEIDSApplicationService : IALL_SLOPEIDSApplicationService
    {
    	public Guid ReturnALL_SLOPEIDSNextValue() 
    	{ 
    		return repository.ReturnALL_SLOPEIDSNextValue();
    	}
                 
    }
    
}
