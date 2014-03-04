using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.S3.Model
{
    public abstract class S3PutWithACLRequest : S3Request
    {        
        private List<S3Grant> _grants;

        /// <summary>
        /// Gets the access control lists (ACLs) for this request. 
        /// Please refer to <see cref="T:Amazon.S3.Model.S3Grant"/> for information on
        /// S3 Grants.
        /// </summary>
        public List<S3Grant> Grants
        {
            get
            {
                if (null == _grants)
                {
                    _grants = new List<S3Grant>();
                }
                return _grants;
            }
        }


    }
}
