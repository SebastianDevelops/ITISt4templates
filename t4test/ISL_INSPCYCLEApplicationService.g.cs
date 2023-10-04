// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SL_INSPCYCLE.cs" company="SANRAL">
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
    /// The SL_INSPCYCLE Application Service.
    /// </summary>
    public  partial class SL_INSPCYCLEApplicationService : ISL_INSPCYCLEApplicationService
    {
    	public Guid ReturnSL_INSPCYCLENextValue() 
    	{ 
    		return repository.ReturnSL_INSPCYCLENextValue();
    	}
                 
    }
    
}
