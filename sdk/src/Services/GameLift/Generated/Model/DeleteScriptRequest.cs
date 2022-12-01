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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteScript operation.
    /// Deletes a Realtime script. This operation permanently deletes the script record. If
    /// script files were uploaded, they are also deleted (files stored in an S3 bucket are
    /// not deleted). 
    /// 
    ///  
    /// <para>
    /// To delete a script, specify the script ID. Before deleting a script, be sure to terminate
    /// all fleets that are deployed with the script being deleted. Fleet instances periodically
    /// check for script updates, and if the script record no longer exists, the instance
    /// will go into an error state and be unable to host game sessions.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/realtime-intro.html">Amazon
    /// GameLift Realtime Servers</a> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Related actions</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
    /// APIs by task</a> 
    /// </para>
    /// </summary>
    public partial class DeleteScriptRequest : AmazonGameLiftRequest
    {
        private string _scriptId;

        /// <summary>
        /// Gets and sets the property ScriptId. 
        /// <para>
        /// A unique identifier for the Realtime script to delete. You can use either the script
        /// ID or ARN value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ScriptId
        {
            get { return this._scriptId; }
            set { this._scriptId = value; }
        }

        // Check to see if ScriptId property is set
        internal bool IsSetScriptId()
        {
            return this._scriptId != null;
        }

    }
}