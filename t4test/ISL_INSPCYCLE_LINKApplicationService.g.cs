// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SL_INSPCYCLE_LINK.cs" company="SANRAL">
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
    /// The SL_INSPCYCLE_LINK Application Service.
    /// </summary>
    public  partial class SL_INSPCYCLE_LINKApplicationService : ISL_INSPCYCLE_LINKApplicationService
    {
    	public Guid ReturnSL_INSPCYCLE_LINKNextValue() 
    	{ 
    		return repository.ReturnSL_INSPCYCLE_LINKNextValue();
    	}
                 
    }
    
}
