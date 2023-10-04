// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SL_OWNER_AUTHORITY.cs" company="SANRAL">
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
    /// The SL_OWNER_AUTHORITY Application Service.
    /// </summary>
    public  partial class SL_OWNER_AUTHORITYApplicationService : ISL_OWNER_AUTHORITYApplicationService
    {
    	public Guid ReturnSL_OWNER_AUTHORITYNextValue() 
    	{ 
    		return repository.ReturnSL_OWNER_AUTHORITYNextValue();
    	}
                 
    }
    
}
