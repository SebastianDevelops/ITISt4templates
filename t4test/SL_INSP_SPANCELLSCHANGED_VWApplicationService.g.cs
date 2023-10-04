// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SL_INSP_SPANCELLSCHANGED_VW.cs" company="SANRAL">
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
    /// The SL_INSP_SPANCELLSCHANGED_VW Application Service.
    /// </summary>
    public  partial class SL_INSP_SPANCELLSCHANGED_VWApplicationService : ISL_INSP_SPANCELLSCHANGED_VWApplicationService
    {
    	public Guid ReturnSL_INSP_SPANCELLSCHANGED_VWNextValue() 
    	{ 
    		return repository.ReturnSL_INSP_SPANCELLSCHANGED_VWNextValue();
    	}
                 
    }
    
}
