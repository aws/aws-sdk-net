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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The configuration for the filter.
    /// </summary>
    public partial class AwsS3BucketBucketLifecycleConfigurationRulesFilterPredicateDetails
    {
        private List<AwsS3BucketBucketLifecycleConfigurationRulesFilterPredicateOperandsDetails> _operands = AWSConfigs.InitializeCollections ? new List<AwsS3BucketBucketLifecycleConfigurationRulesFilterPredicateOperandsDetails>() : null;
        private string _prefix;
        private AwsS3BucketBucketLifecycleConfigurationRulesFilterPredicateTagDetails _tag;
        private string _type;

        /// <summary>
        /// Gets and sets the property Operands. 
        /// <para>
        /// The values to use for the filter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsS3BucketBucketLifecycleConfigurationRulesFilterPredicateOperandsDetails> Operands
        {
            get { return this._operands; }
            set { this._operands = value; }
        }

        // Check to see if Operands property is set
        internal bool IsSetOperands()
        {
            return this._operands != null && (this._operands.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// A prefix filter.
        /// </para>
        /// </summary>
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

        /// <summary>
        /// Gets and sets the property Tag. 
        /// <para>
        /// A tag filter.
        /// </para>
        /// </summary>
        public AwsS3BucketBucketLifecycleConfigurationRulesFilterPredicateTagDetails Tag
        {
            get { return this._tag; }
            set { this._tag = value; }
        }

        // Check to see if Tag property is set
        internal bool IsSetTag()
        {
            return this._tag != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Whether to use <c>AND</c> or <c>OR</c> to join the operands. Valid values are <c>LifecycleAndOperator</c>
        /// or <c>LifecycleOrOperator</c>.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}