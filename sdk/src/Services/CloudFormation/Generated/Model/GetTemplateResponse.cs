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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The output for <a>GetTemplate</a> action.
    /// </summary>
    public partial class GetTemplateResponse : AmazonWebServiceResponse
    {
        private List<string> _stagesAvailable = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _templateBody;

        /// <summary>
        /// Gets and sets the property StagesAvailable. 
        /// <para>
        /// The stage of the template that you can retrieve. For stacks, the <c>Original</c> and
        /// <c>Processed</c> templates are always available. For change sets, the <c>Original</c>
        /// template is always available. After CloudFormation finishes creating the change set,
        /// the <c>Processed</c> template becomes available.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StagesAvailable
        {
            get { return this._stagesAvailable; }
            set { this._stagesAvailable = value; }
        }

        // Check to see if StagesAvailable property is set
        internal bool IsSetStagesAvailable()
        {
            return this._stagesAvailable != null && (this._stagesAvailable.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TemplateBody. 
        /// <para>
        /// Structure that contains the template body.
        /// </para>
        ///  
        /// <para>
        /// CloudFormation returns the same template that was used when the stack was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string TemplateBody
        {
            get { return this._templateBody; }
            set { this._templateBody = value; }
        }

        // Check to see if TemplateBody property is set
        internal bool IsSetTemplateBody()
        {
            return this._templateBody != null;
        }

    }
}