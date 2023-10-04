// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SL_PACKAGE.cs" company="SANRAL">
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
    /// The SL_PACKAGE Application Service.
    /// </summary>
    public  partial class SL_PACKAGEApplicationService : ISL_PACKAGEApplicationService
    {
    	public Guid ReturnSL_PACKAGENextValue() 
    	{ 
    		return repository.ReturnSL_PACKAGENextValue();
    	}
                 
    }
    
}
