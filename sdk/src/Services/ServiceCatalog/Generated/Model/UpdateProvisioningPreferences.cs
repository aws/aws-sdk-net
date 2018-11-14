/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// The user-defined preferences that will be applied when updating a provisioned product.
    /// Not all preferences are applicable to all provisioned product types.
    /// </summary>
    public partial class UpdateProvisioningPreferences
    {
        private List<string> _stackSetAccounts = new List<string>();
        private int? _stackSetFailureToleranceCount;
        private int? _stackSetFailureTolerancePercentage;
        private int? _stackSetMaxConcurrencyCount;
        private int? _stackSetMaxConcurrencyPercentage;
        private StackSetOperationType _stackSetOperationType;
        private List<string> _stackSetRegions = new List<string>();

        /// <summary>
        /// Gets and sets the property StackSetAccounts. 
        /// <para>
        /// One or more AWS accounts that will have access to the provisioned product.
        /// </para>
        ///  
        /// <para>
        /// Applicable only to a <code>CFN_STACKSET</code> provisioned product type.
        /// </para>
        ///  
        /// <para>
        /// The AWS accounts specified should be within the list of accounts in the <code>STACKSET</code>
        /// constraint. To get the list of accounts in the <code>STACKSET</code> constraint, use
        /// the <code>DescribeProvisioningParameters</code> operation.
        /// </para>
        ///  
        /// <para>
        /// If no values are specified, the default value is all accounts from the <code>STACKSET</code>
        /// constraint.
        /// </para>
        /// </summary>
        public List<string> StackSetAccounts
        {
            get { return this._stackSetAccounts; }
            set { this._stackSetAccounts = value; }
        }

        // Check to see if StackSetAccounts property is set
        internal bool IsSetStackSetAccounts()
        {
            return this._stackSetAccounts != null && this._stackSetAccounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StackSetFailureToleranceCount. 
        /// <para>
        /// The number of accounts, per region, for which this operation can fail before AWS Service
        /// Catalog stops the operation in that region. If the operation is stopped in a region,
        /// AWS Service Catalog doesn't attempt the operation in any subsequent regions.
        /// </para>
        ///  
        /// <para>
        /// Applicable only to a <code>CFN_STACKSET</code> provisioned product type.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either <code>StackSetFailureToleranceCount</code> or
        /// <code>StackSetFailureTolerancePercentage</code>, but not both.
        /// </para>
        ///  
        /// <para>
        /// The default value is <code>0</code> if no value is specified.
        /// </para>
        /// </summary>
        public int StackSetFailureToleranceCount
        {
            get { return this._stackSetFailureToleranceCount.GetValueOrDefault(); }
            set { this._stackSetFailureToleranceCount = value; }
        }

        // Check to see if StackSetFailureToleranceCount property is set
        internal bool IsSetStackSetFailureToleranceCount()
        {
            return this._stackSetFailureToleranceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StackSetFailureTolerancePercentage. 
        /// <para>
        /// The percentage of accounts, per region, for which this stack operation can fail before
        /// AWS Service Catalog stops the operation in that region. If the operation is stopped
        /// in a region, AWS Service Catalog doesn't attempt the operation in any subsequent regions.
        /// </para>
        ///  
        /// <para>
        /// When calculating the number of accounts based on the specified percentage, AWS Service
        /// Catalog rounds down to the next whole number.
        /// </para>
        ///  
        /// <para>
        /// Applicable only to a <code>CFN_STACKSET</code> provisioned product type.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either <code>StackSetFailureToleranceCount</code> or
        /// <code>StackSetFailureTolerancePercentage</code>, but not both.
        /// </para>
        /// </summary>
        public int StackSetFailureTolerancePercentage
        {
            get { return this._stackSetFailureTolerancePercentage.GetValueOrDefault(); }
            set { this._stackSetFailureTolerancePercentage = value; }
        }

        // Check to see if StackSetFailureTolerancePercentage property is set
        internal bool IsSetStackSetFailureTolerancePercentage()
        {
            return this._stackSetFailureTolerancePercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StackSetMaxConcurrencyCount. 
        /// <para>
        /// The maximum number of accounts in which to perform this operation at one time. This
        /// is dependent on the value of <code>StackSetFailureToleranceCount</code>. <code>StackSetMaxConcurrentCount</code>
        /// is at most one more than the <code>StackSetFailureToleranceCount</code>.
        /// </para>
        ///  
        /// <para>
        /// Note that this setting lets you specify the maximum for operations. For large deployments,
        /// under certain circumstances the actual number of accounts acted upon concurrently
        /// may be lower due to service throttling.
        /// </para>
        ///  
        /// <para>
        /// Applicable only to a <code>CFN_STACKSET</code> provisioned product type.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either <code>StackSetMaxConcurrentCount</code> or <code>StackSetMaxConcurrentPercentage</code>,
        /// but not both.
        /// </para>
        /// </summary>
        public int StackSetMaxConcurrencyCount
        {
            get { return this._stackSetMaxConcurrencyCount.GetValueOrDefault(); }
            set { this._stackSetMaxConcurrencyCount = value; }
        }

        // Check to see if StackSetMaxConcurrencyCount property is set
        internal bool IsSetStackSetMaxConcurrencyCount()
        {
            return this._stackSetMaxConcurrencyCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StackSetMaxConcurrencyPercentage. 
        /// <para>
        /// The maximum percentage of accounts in which to perform this operation at one time.
        /// </para>
        ///  
        /// <para>
        /// When calculating the number of accounts based on the specified percentage, AWS Service
        /// Catalog rounds down to the next whole number. This is true except in cases where rounding
        /// down would result is zero. In this case, AWS Service Catalog sets the number as <code>1</code>
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
        /// Applicable only to a <code>CFN_STACKSET</code> provisioned product type.
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either <code>StackSetMaxConcurrentCount</code> or <code>StackSetMaxConcurrentPercentage</code>,
        /// but not both.
        /// </para>
        /// </summary>
        public int StackSetMaxConcurrencyPercentage
        {
            get { return this._stackSetMaxConcurrencyPercentage.GetValueOrDefault(); }
            set { this._stackSetMaxConcurrencyPercentage = value; }
        }

        // Check to see if StackSetMaxConcurrencyPercentage property is set
        internal bool IsSetStackSetMaxConcurrencyPercentage()
        {
            return this._stackSetMaxConcurrencyPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StackSetOperationType. 
        /// <para>
        /// Determines what action AWS Service Catalog performs to a stack set or a stack instance
        /// represented by the provisioned product. The default value is <code>UPDATE</code> if
        /// nothing is specified.
        /// </para>
        ///  
        /// <para>
        /// Applicable only to a <code>CFN_STACKSET</code> provisioned product type.
        /// </para>
        ///  <dl> <dt>CREATE</dt> <dd> 
        /// <para>
        /// Creates a new stack instance in the stack set represented by the provisioned product.
        /// In this case, only new stack instances are created based on accounts and regions;
        /// if new ProductId or ProvisioningArtifactID are passed, they will be ignored.
        /// </para>
        ///  </dd> <dt>UPDATE</dt> <dd> 
        /// <para>
        /// Updates the stack set represented by the provisioned product and also its stack instances.
        /// </para>
        ///  </dd> <dt>DELETE</dt> <dd> 
        /// <para>
        /// Deletes a stack instance in the stack set represented by the provisioned product.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public StackSetOperationType StackSetOperationType
        {
            get { return this._stackSetOperationType; }
            set { this._stackSetOperationType = value; }
        }

        // Check to see if StackSetOperationType property is set
        internal bool IsSetStackSetOperationType()
        {
            return this._stackSetOperationType != null;
        }

        /// <summary>
        /// Gets and sets the property StackSetRegions. 
        /// <para>
        /// One or more AWS Regions where the provisioned product will be available.
        /// </para>
        ///  
        /// <para>
        /// Applicable only to a <code>CFN_STACKSET</code> provisioned product type.
        /// </para>
        ///  
        /// <para>
        /// The specified regions should be within the list of regions from the <code>STACKSET</code>
        /// constraint. To get the list of regions in the <code>STACKSET</code> constraint, use
        /// the <code>DescribeProvisioningParameters</code> operation.
        /// </para>
        ///  
        /// <para>
        /// If no values are specified, the default value is all regions from the <code>STACKSET</code>
        /// constraint.
        /// </para>
        /// </summary>
        public List<string> StackSetRegions
        {
            get { return this._stackSetRegions; }
            set { this._stackSetRegions = value; }
        }

        // Check to see if StackSetRegions property is set
        internal bool IsSetStackSetRegions()
        {
            return this._stackSetRegions != null && this._stackSetRegions.Count > 0; 
        }

    }
}