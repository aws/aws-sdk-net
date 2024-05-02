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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateNumberOfDomainControllers operation.
    /// Adds or removes domain controllers to or from the directory. Based on the difference
    /// between current value and new value (provided through this API call), domain controllers
    /// will be added or removed. It may take up to 45 minutes for any new domain controllers
    /// to become fully active once the requested number of domain controllers is updated.
    /// During this time, you cannot make another update request.
    /// </summary>
    public partial class UpdateNumberOfDomainControllersRequest : AmazonDirectoryServiceRequest
    {
        private int? _desiredNumber;
        private string _directoryId;

        /// <summary>
        /// Gets and sets the property DesiredNumber. 
        /// <para>
        /// The number of domain controllers desired in the directory.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2)]
        public int? DesiredNumber
        {
            get { return this._desiredNumber; }
            set { this._desiredNumber = value; }
        }

        // Check to see if DesiredNumber property is set
        internal bool IsSetDesiredNumber()
        {
            return this._desiredNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// Identifier of the directory to which the domain controllers will be added or removed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

    }
}