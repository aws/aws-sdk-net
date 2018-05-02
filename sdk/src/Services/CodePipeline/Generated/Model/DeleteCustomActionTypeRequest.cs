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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteCustomActionType operation.
    /// Marks a custom action as deleted. PollForJobs for the custom action will fail after
    /// the action is marked for deletion. Only used for custom actions.
    /// 
    ///  <important> 
    /// <para>
    /// To re-create a custom action after it has been deleted you must use a string in the
    /// version field that has never been used before. This string can be an incremented version
    /// number, for example. To restore a deleted custom action, use a JSON file that is identical
    /// to the deleted action, including the original string in the version field.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DeleteCustomActionTypeRequest : AmazonCodePipelineRequest
    {
        private ActionCategory _category;
        private string _provider;
        private string _version;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of the custom action that you want to delete, such as source or deploy.
        /// </para>
        /// </summary>
        public ActionCategory Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The provider of the service used in the custom action, such as AWS CodeDeploy.
        /// </para>
        /// </summary>
        public string Provider
        {
            get { return this._provider; }
            set { this._provider = value; }
        }

        // Check to see if Provider property is set
        internal bool IsSetProvider()
        {
            return this._provider != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the custom action to delete.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}