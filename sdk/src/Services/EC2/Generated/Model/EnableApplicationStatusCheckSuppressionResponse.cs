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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the EnableApplicationStatusCheckSuppression operation.
    /// </summary>
    public partial class EnableApplicationStatusCheckSuppressionResponse : AmazonWebServiceResponse
    {
        private List<SuccessfulSuppressionResponseObject> _successfulResults = AWSConfigs.InitializeCollections ? new List<SuccessfulSuppressionResponseObject>() : null;
        private List<UnsuccessfulSuppressionResponseObject> _unsuccessfulResults = AWSConfigs.InitializeCollections ? new List<UnsuccessfulSuppressionResponseObject>() : null;

        /// <summary>
        /// Gets and sets the property SuccessfulResults. 
        /// <para>
        /// The instances for which suppression was successfully enabled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SuccessfulSuppressionResponseObject> SuccessfulResults
        {
            get { return this._successfulResults; }
            set { this._successfulResults = value; }
        }

        // Check to see if SuccessfulResults property is set
        internal bool IsSetSuccessfulResults()
        {
            return this._successfulResults != null && (this._successfulResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnsuccessfulResults. 
        /// <para>
        /// The instances for which suppression failed to be enabled.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UnsuccessfulSuppressionResponseObject> UnsuccessfulResults
        {
            get { return this._unsuccessfulResults; }
            set { this._unsuccessfulResults = value; }
        }

        // Check to see if UnsuccessfulResults property is set
        internal bool IsSetUnsuccessfulResults()
        {
            return this._unsuccessfulResults != null && (this._unsuccessfulResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}