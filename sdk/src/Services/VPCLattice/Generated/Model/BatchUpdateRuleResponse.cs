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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
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
namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// This is the response object from the BatchUpdateRule operation.
    /// </summary>
    public partial class BatchUpdateRuleResponse : AmazonWebServiceResponse
    {
        private List<RuleUpdateSuccess> _successful = AWSConfigs.InitializeCollections ? new List<RuleUpdateSuccess>() : null;
        private List<RuleUpdateFailure> _unsuccessful = AWSConfigs.InitializeCollections ? new List<RuleUpdateFailure>() : null;

        /// <summary>
        /// Gets and sets the property Successful. 
        /// <para>
        /// The rules that were successfully updated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RuleUpdateSuccess> Successful
        {
            get { return this._successful; }
            set { this._successful = value; }
        }

        // Check to see if Successful property is set
        internal bool IsSetSuccessful()
        {
            return this._successful != null && (this._successful.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Unsuccessful. 
        /// <para>
        /// The rules that the operation couldn't update.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RuleUpdateFailure> Unsuccessful
        {
            get { return this._unsuccessful; }
            set { this._unsuccessful = value; }
        }

        // Check to see if Unsuccessful property is set
        internal bool IsSetUnsuccessful()
        {
            return this._unsuccessful != null && (this._unsuccessful.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}