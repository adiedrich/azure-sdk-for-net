// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Search.Models
{
    /// <summary>
    /// Provides parameter values to a magnitude scoring function.
    /// </summary>
    public partial class MagnitudeScoringParameters
    {
        private double _boostingRangeEnd;
        
        /// <summary>
        /// Required. Gets or sets the field value at which boosting ends.
        /// </summary>
        public double BoostingRangeEnd
        {
            get { return this._boostingRangeEnd; }
            set { this._boostingRangeEnd = value; }
        }
        
        private double _boostingRangeStart;
        
        /// <summary>
        /// Required. Gets or sets the field value at which boosting starts.
        /// </summary>
        public double BoostingRangeStart
        {
            get { return this._boostingRangeStart; }
            set { this._boostingRangeStart = value; }
        }
        
        private bool _shouldBoostBeyondRangeByConstant;
        
        /// <summary>
        /// Optional. Gets or sets a value indicating whether to apply a
        /// constant boost for field values beyond the range end value;
        /// default is false.
        /// </summary>
        public bool ShouldBoostBeyondRangeByConstant
        {
            get { return this._shouldBoostBeyondRangeByConstant; }
            set { this._shouldBoostBeyondRangeByConstant = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the MagnitudeScoringParameters class.
        /// </summary>
        public MagnitudeScoringParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the MagnitudeScoringParameters class
        /// with required arguments.
        /// </summary>
        public MagnitudeScoringParameters(double boostingRangeStart, double boostingRangeEnd)
            : this()
        {
            this.BoostingRangeStart = boostingRangeStart;
            this.BoostingRangeEnd = boostingRangeEnd;
        }
    }
}
