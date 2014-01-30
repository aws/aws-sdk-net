/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes an IAM instance profile.</para>
    /// </summary>
    public class IamInstanceProfile
    {
        
        private string arn;
        private string id;


        /// <summary>
        /// The Amazon Resource Name (ARN) of the instance profile.
        ///  
        /// </summary>
        public string Arn
        {
            get { return this.arn; }
            set { this.arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this.arn != null;
        }

        /// <summary>
        /// The ID of the instance profile.
        ///  
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }
    }
}
