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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
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
namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIntentVersion operation.
    /// Creates a new version of an intent based on the <c>$LATEST</c> version of the intent.
    /// If the <c>$LATEST</c> version of this intent hasn't changed since you last updated
    /// it, Amazon Lex doesn't create a new version. It returns the last version you created.
    /// 
    ///  <note> 
    /// <para>
    /// You can update only the <c>$LATEST</c> version of the intent. You can't update the
    /// numbered versions that you create with the <c>CreateIntentVersion</c> operation.
    /// </para>
    ///  </note> 
    /// <para>
    ///  When you create a version of an intent, Amazon Lex sets the version to 1. Subsequent
    /// versions increment by 1. For more information, see <a>versioning-intro</a>. 
    /// </para>
    ///  
    /// <para>
    /// This operation requires permissions to perform the <c>lex:CreateIntentVersion</c>
    /// action. 
    /// </para>
    /// </summary>
    public partial class CreateIntentVersionRequest : AmazonLexModelBuildingServiceRequest
    {
        private string _checksum;
        private string _name;

        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// Checksum of the <c>$LATEST</c> version of the intent that should be used to create
        /// the new version. If you specify a checksum and the <c>$LATEST</c> version of the intent
        /// has a different checksum, Amazon Lex returns a <c>PreconditionFailedException</c>
        /// exception and doesn't publish a new version. If you don't specify a checksum, Amazon
        /// Lex publishes the <c>$LATEST</c> version.
        /// </para>
        /// </summary>
        public string Checksum
        {
            get { return this._checksum; }
            set { this._checksum = value; }
        }

        // Check to see if Checksum property is set
        internal bool IsSetChecksum()
        {
            return this._checksum != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the intent that you want to create a new version of. The name is case
        /// sensitive. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}