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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the GenerateQuery operation.
    /// Generates a query from a natural language prompt. This operation uses generative
    /// artificial intelligence (generative AI) to produce a ready-to-use SQL query from the
    /// prompt. 
    /// 
    ///  
    /// <para>
    /// The prompt can be a question or a statement about the event data in your event data
    /// store. For example, you can enter prompts like "What are my top errors in the past
    /// month?" and “Give me a list of users that used SNS.”
    /// </para>
    ///  
    /// <para>
    /// The prompt must be in English. For information about limitations, permissions, and
    /// supported Regions, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/lake-query-generator.html">Create
    /// CloudTrail Lake queries from natural language prompts</a> in the <i>CloudTrail </i>
    /// user guide.
    /// </para>
    ///  <note> 
    /// <para>
    /// Do not include any personally identifying, confidential, or sensitive information
    /// in your prompts.
    /// </para>
    ///  
    /// <para>
    /// This feature uses generative AI large language models (LLMs); we recommend double-checking
    /// the LLM response.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GenerateQueryRequest : AmazonCloudTrailRequest
    {
        private List<string> _eventDataStores = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _prompt;

        /// <summary>
        /// Gets and sets the property EventDataStores. 
        /// <para>
        ///  The ARN (or ID suffix of the ARN) of the event data store that you want to query.
        /// You can only specify one event data store. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<string> EventDataStores
        {
            get { return this._eventDataStores; }
            set { this._eventDataStores = value; }
        }

        // Check to see if EventDataStores property is set
        internal bool IsSetEventDataStores()
        {
            return this._eventDataStores != null && (this._eventDataStores.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Prompt. 
        /// <para>
        ///  The prompt that you want to use to generate the query. The prompt must be in English.
        /// For example prompts, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/lake-query-generator.html#lake-query-generator-examples">Example
        /// prompts</a> in the <i>CloudTrail </i> user guide. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=500)]
        public string Prompt
        {
            get { return this._prompt; }
            set { this._prompt = value; }
        }

        // Check to see if Prompt property is set
        internal bool IsSetPrompt()
        {
            return this._prompt != null;
        }

    }
}