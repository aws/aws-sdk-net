/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes the recommendation options for licenses.
    /// </summary>
    public partial class LicenseRecommendationOption
    {
        private LicenseEdition _licenseEdition;
        private LicenseModel _licenseModel;
        private string _operatingSystem;
        private int? _rank;
        private SavingsOpportunity _savingsOpportunity;

        /// <summary>
        /// Gets and sets the property LicenseEdition. 
        /// <para>
        ///  The recommended edition of the license for the application that runs on the instance.
        /// 
        /// </para>
        /// </summary>
        public LicenseEdition LicenseEdition
        {
            get { return this._licenseEdition; }
            set { this._licenseEdition = value; }
        }

        // Check to see if LicenseEdition property is set
        internal bool IsSetLicenseEdition()
        {
            return this._licenseEdition != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        ///  The recommended license type associated with the instance. 
        /// </para>
        /// </summary>
        public LicenseModel LicenseModel
        {
            get { return this._licenseModel; }
            set { this._licenseModel = value; }
        }

        // Check to see if LicenseModel property is set
        internal bool IsSetLicenseModel()
        {
            return this._licenseModel != null;
        }

        /// <summary>
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        ///  The operating system of a license recommendation option. 
        /// </para>
        /// </summary>
        public string OperatingSystem
        {
            get { return this._operatingSystem; }
            set { this._operatingSystem = value; }
        }

        // Check to see if OperatingSystem property is set
        internal bool IsSetOperatingSystem()
        {
            return this._operatingSystem != null;
        }

        /// <summary>
        /// Gets and sets the property Rank. 
        /// <para>
        ///  The rank of the license recommendation option. 
        /// </para>
        ///  
        /// <para>
        ///  The top recommendation option is ranked as <c>1</c>. 
        /// </para>
        /// </summary>
        public int? Rank
        {
            get { return this._rank; }
            set { this._rank = value; }
        }

        // Check to see if Rank property is set
        internal bool IsSetRank()
        {
            return this._rank.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SavingsOpportunity.
        /// </summary>
        public SavingsOpportunity SavingsOpportunity
        {
            get { return this._savingsOpportunity; }
            set { this._savingsOpportunity = value; }
        }

        // Check to see if SavingsOpportunity property is set
        internal bool IsSetSavingsOpportunity()
        {
            return this._savingsOpportunity != null;
        }

    }
}