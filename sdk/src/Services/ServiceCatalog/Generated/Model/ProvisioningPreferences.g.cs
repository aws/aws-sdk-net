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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// The user-defined preferences that will be applied when updating a provisioned product.
    /// Not all preferences are applicable to all provisioned product type
    /// 
    ///  
    /// <para>
    /// One or more Amazon Web Services accounts that will have access to the provisioned
    /// product.
    /// </para>
    ///  
    /// <para>
    /// Applicable only to a <c>CFN_STACKSET</c> provisioned product type.
    /// </para>
    ///  
    /// <para>
    /// The Amazon Web Services accounts specified should be within the list of accounts in
    /// the <c>STACKSET</c> constraint. To get the list of accounts in the <c>STACKSET</c>
    /// constraint, use the <c>DescribeProvisioningParameters</c> operation.
    /// </para>
    ///  
    /// <para>
    /// If no values are specified, the default value is all accounts from the <c>STACKSET</c>
    /// constraint.
    /// </para>
    /// </summary>
    public partial class ProvisioningPreferences
    {
        /// <summary>
        /// Gets and sets the property StackSetAccounts. 
        /// <para>
        /// One or more Amazon Web Services accounts where the provisioned product will be available.
        /// </para>
        ///  
        /// <para>
        /// Applicable only to a <c>CFN_STACKSET</c> provisioned product type.
        /// </para>
        ///  
        /// <para>
        /// The specified accounts should be within the list of accounts from the <c>STACKSET</c>
        /// constraint. To get the list of accounts in the <c>STACKSET</c> constraint, use the
        /// <c>DescribeProvisioningParameters</c> operation.
        /// </para>
        ///  
        /// <para>
        /// If no values are specified, the default value is all acounts from the <c>STACKSET</c>
        /// constraint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StackSetAccounts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StackSetAccounts property is set.
        /// </summary>
        internal bool IsSetStackSetAccounts() => this.StackSetAccounts != null && (this.StackSetAccounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StackSetFailureToleranceCount. 
        /// <para>
        /// The number of accounts, per Region, for which this operation can fail before Service
        /// Catalog stops the operation in that Region. If the operation is stopped in a Region,
        /// Service Catalog doesn't attempt the operation in any subsequent Regions.
        /// </para>
        ///  
        /// <para>
        /// Applicable only to a <c>CFN_STACKSET</c> provisioned product type.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either <c>StackSetFailureToleranceCount</c> or <c>StackSetFailureTolerancePercentage</c>,
        /// but not both.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>0</c> if no value is specified.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? StackSetFailureToleranceCount { get; set; }

        /// <summary>
        /// Checks to see if the StackSetFailureToleranceCount property is set.
        /// </summary>
        internal bool IsSetStackSetFailureToleranceCount() => this.StackSetFailureToleranceCount.HasValue;

        /// <summary>
        /// Gets and sets the property StackSetFailureTolerancePercentage. 
        /// <para>
        /// The percentage of accounts, per Region, for which this stack operation can fail before
        /// Service Catalog stops the operation in that Region. If the operation is stopped in
        /// a Region, Service Catalog doesn't attempt the operation in any subsequent Regions.
        /// </para>
        ///  
        /// <para>
        /// When calculating the number of accounts based on the specified percentage, Service
        /// Catalog rounds down to the next whole number.
        /// </para>
        ///  
        /// <para>
        /// Applicable only to a <c>CFN_STACKSET</c> provisioned product type.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either <c>StackSetFailureToleranceCount</c> or <c>StackSetFailureTolerancePercentage</c>,
        /// but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? StackSetFailureTolerancePercentage { get; set; }

        /// <summary>
        /// Checks to see if the StackSetFailureTolerancePercentage property is set.
        /// </summary>
        internal bool IsSetStackSetFailureTolerancePercentage() => this.StackSetFailureTolerancePercentage.HasValue;

        /// <summary>
        /// Gets and sets the property StackSetMaxConcurrencyCount. 
        /// <para>
        /// The maximum number of accounts in which to perform this operation at one time. This
        /// is dependent on the value of <c>StackSetFailureToleranceCount</c>. <c>StackSetMaxConcurrentCount</c>
        /// is at most one more than the <c>StackSetFailureToleranceCount</c>.
        /// </para>
        ///  
        /// <para>
        /// Note that this setting lets you specify the maximum for operations. For large deployments,
        /// under certain circumstances the actual number of accounts acted upon concurrently
        /// may be lower due to service throttling.
        /// </para>
        ///  
        /// <para>
        /// Applicable only to a <c>CFN_STACKSET</c> provisioned product type.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either <c>StackSetMaxConcurrentCount</c> or <c>StackSetMaxConcurrentPercentage</c>,
        /// but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? StackSetMaxConcurrencyCount { get; set; }

        /// <summary>
        /// Checks to see if the StackSetMaxConcurrencyCount property is set.
        /// </summary>
        internal bool IsSetStackSetMaxConcurrencyCount() => this.StackSetMaxConcurrencyCount.HasValue;

        /// <summary>
        /// Gets and sets the property StackSetMaxConcurrencyPercentage. 
        /// <para>
        /// The maximum percentage of accounts in which to perform this operation at one time.
        /// </para>
        ///  
        /// <para>
        /// When calculating the number of accounts based on the specified percentage, Service
        /// Catalog rounds down to the next whole number. This is true except in cases where rounding
        /// down would result is zero. In this case, Service Catalog sets the number as <c>1</c>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// Note that this setting lets you specify the maximum for operations. For large deployments,
        /// under certain circumstances the actual number of accounts acted upon concurrently
        /// may be lower due to service throttling.
        /// </para>
        ///  
        /// <para>
        /// Applicable only to a <c>CFN_STACKSET</c> provisioned product type.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either <c>StackSetMaxConcurrentCount</c> or <c>StackSetMaxConcurrentPercentage</c>,
        /// but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? StackSetMaxConcurrencyPercentage { get; set; }

        /// <summary>
        /// Checks to see if the StackSetMaxConcurrencyPercentage property is set.
        /// </summary>
        internal bool IsSetStackSetMaxConcurrencyPercentage() => this.StackSetMaxConcurrencyPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property StackSetRegions. 
        /// <para>
        /// One or more Amazon Web Services Regions where the provisioned product will be available.
        /// </para>
        ///  
        /// <para>
        /// Applicable only to a <c>CFN_STACKSET</c> provisioned product type.
        /// </para>
        ///  
        /// <para>
        /// The specified Regions should be within the list of Regions from the <c>STACKSET</c>
        /// constraint. To get the list of Regions in the <c>STACKSET</c> constraint, use the
        /// <c>DescribeProvisioningParameters</c> operation.
        /// </para>
        ///  
        /// <para>
        /// If no values are specified, the default value is all Regions from the <c>STACKSET</c>
        /// constraint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StackSetRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StackSetRegions property is set.
        /// </summary>
        internal bool IsSetStackSetRegions() => this.StackSetRegions != null && (this.StackSetRegions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
