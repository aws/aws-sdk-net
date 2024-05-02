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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAudienceModel operation.
    /// Specifies an audience model that you want to delete. You can't delete an audience
    /// model if there are any configured audience models that depend on the audience model.
    /// </summary>
    public partial class DeleteAudienceModelRequest : AmazonCleanRoomsMLRequest
    {
        private string _audienceModelArn;

        /// <summary>
        /// Gets and sets the property AudienceModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the audience model that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string AudienceModelArn
        {
            get { return this._audienceModelArn; }
            set { this._audienceModelArn = value; }
        }

        // Check to see if AudienceModelArn property is set
        internal bool IsSetAudienceModelArn()
        {
            return this._audienceModelArn != null;
        }

    }
}